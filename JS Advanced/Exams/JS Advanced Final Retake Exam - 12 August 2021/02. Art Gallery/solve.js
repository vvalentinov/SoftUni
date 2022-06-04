class ArtGallery {
    constructor(creator) {
        this.creator = creator;
        this.possibleArticles = {
            "picture": 200,
            "photo": 50,
            "item": 250
        };

        this.listOfArticles = [];
        this.guests = [];
    }

    addArticle(articleModel, articleName, quantity) {
        articleModel = articleModel.toLowerCase();
        if (this.possibleArticles.hasOwnProperty(articleModel) == false) {
            throw new Error('This article model is not included in this gallery!');
        }

        let article = this.listOfArticles.find(a => a.articleName == articleName && a.articleModel == articleModel);

        if (article != undefined) {
            article.quantity += quantity;
        } else {
            this.listOfArticles.push({ articleModel, articleName, quantity });
        }

        return `Successfully added article ${articleName} with a new quantity- ${quantity}.`; // ????
    }

    inviteGuest(guestName, personality) {
        let guest = this.guests.find(g => g.guestName == guestName);
        if (guest != undefined) {
            throw new Error(`${guestName} has already been invited.`);
        }
        let points = 50;
        if (personality == 'Vip') {
            points = 500;
        } else if (personality == 'Middle') {
            points = 250;
        }

        this.guests.push({ guestName, points, purchaseArticle: 0 });

        return `You have successfully invited ${guestName}!`;
    }

    buyArticle(articleModel, articleName, guestName) {
        articleModel = articleModel.toLowerCase();
        let article = this.listOfArticles.find(a => a.articleName == articleName && a.articleModel == articleModel);
        if (article == undefined) {
            throw new Error('This article is not found.');
        }

        if (article.quantity == 0) {
            return `The ${articleName} is not available.`;
        }

        let guest = this.guests.find(g => g.guestName == guestName);
        if (guest == undefined) {
            return 'This guest is not invited.';
        }

        if (guest.points < this.possibleArticles[articleModel]) {
            return 'You need to more points to purchase the article.';
        } else {
            guest.points -= this.possibleArticles[articleModel];
            article.quantity--;
            guest.purchaseArticle++;
        }

        return `${guestName} successfully purchased the article worth ${this.possibleArticles[articleModel]} points.`;
    }

    showGalleryInfo(criteria) {
        if (criteria == 'article') {
            let message = 'Articles information:\n';
            this.listOfArticles.forEach((a, index) => {
                if (index == this.listOfArticles.length - 1) {
                    message += `${a.articleModel} - ${a.articleName} - ${a.quantity}`;
                } else {
                    message += `${a.articleModel} - ${a.articleName} - ${a.quantity}\n`;
                }

            });
            return message;
        } else if (criteria == 'guest') {
            let message = 'Guests information:\n';
            this.guests.forEach((g, index) => {
                if (index == this.guests.length - 1) {
                    message += `${g.guestName} - ${g.purchaseArticle}`;
                } else {
                    message += `${g.guestName} - ${g.purchaseArticle}\n`;
                }

            });
            return message;
        }
    }
}