class Story {
    #comments;
    #likes;
    constructor(title, creator){
        this.title = title;
        this.creator = creator;
        this.#likes = [];
        this.#comments = [];
    }

    get likes(){
        if (this.#likes.length == 0) {
            return `${this.title} has 0 likes`;
        } else if (this.#likes.length == 1){
            return `${this.#likes[0]} likes this story!`;
        } else {
            return `${this.#likes[0]} and ${this.#likes.length - 1} others like this story!`;
        }
    }

    like(username) {
        if (this.#likes.includes(username)) {
            throw new Error("You can't like the same story twice!");
        } else if (username == this.creator){
            throw new Error("You can't like your own story!");
        } else {
            this.#likes.push(username);
            return `${username} liked ${this.title}!`;
        }
    }

    dislike(username) {
        if (!this.#likes.includes(username)) {
            throw new Error("You can't dislike this story!");
        } else {
            this.#likes.splice(this.#likes.indexOf(username), 1);
            return `${username} disliked ${this.title}`;
        }
    }
    
    comment(username, content, id) {
        if (id == undefined || this.#comments.find(c => c.Id == id) == undefined) {
            let comment = {
                Id: this.#comments.length + 1,
                Username: username,
                Content: content,
                Replies: []
            };
            this.#comments.push(comment);
            return `${username} commented on ${this.title}`;
        } else {
            let comment = this.#comments.find(c => c.Id == id);
            let reply = {
                Id: Number(comment.Id + '.' + (comment.Replies.length + 1)),
                Username: username,
                Content: content,
            };
            comment.Replies.push(reply);
            return 'You replied successfully';
        }
    }

    toString(sortingType) {
        let result = [`Title: ${this.title}\nCreator: ${this.creator}\nLikes: ${this.#likes.length}\nComments:`];
        if (this.#comments.length > 0) {
            if (sortingType == 'asc') {
                this.#comments = this.#comments.sort((a, b) => a.Id - b.Id);
                this.#comments.forEach(comment => {
                    result.push(`-- ${comment.Id}. ${comment.Username}: ${comment.Content}`);
                    comment.Replies.sort((a, b) => a.Id - b.Id).forEach(reply => {result.push(`--- ${reply.Id}. ${reply.Username}: ${reply.Content}`);});
                });
            } else if (sortingType == 'desc') {
                this.#comments = this.#comments.sort((a, b) => b.Id - a.Id);
                this.#comments.forEach(comment => {
                    result.push(`-- ${comment.Id}. ${comment.Username}: ${comment.Content}`);
                    comment.Replies.sort((a, b) => b.Id - a.Id).forEach(reply => {result.push(`--- ${reply.Id}. ${reply.Username}: ${reply.Content}`);});
                });
            } else if(sortingType == 'username'){
                this.#comments = this.#comments.sort((a, b) => a.Username.localeCompare(b.Username));
                this.#comments.forEach(comment => {
                    result.push(`-- ${comment.Id}. ${comment.Username}: ${comment.Content}`);
                    comment.Replies.sort((a, b) => a.Username.localeCompare(b.Username)).forEach(reply => {
                        result.push(`--- ${reply.Id}. ${reply.Username}: ${reply.Content}`);
                    });
                });
            }
        }
        return result.join('\n');
    }
}