function result(argument) {

    if (argument == 'upvote') {
        return this.upvotes++;
    }

    if (argument == 'downvote') {
        return this.downvotes++;
    }

    let upvotesCount = this.upvotes;
    let downvotesCount = this.downvotes;
    let totalVotes = upvotesCount + downvotesCount;
    let balance = upvotesCount - downvotesCount;

    function rating() {
        if (totalVotes < 10) {
            return 'new';
        }
        if (upvotesCount > totalVotes * 0.66) {
            return 'hot';
        }
        if (balance >= 0 && totalVotes > 100) {
            return 'controversial';
        }
        if (balance < 0) {
            return 'unpopular';
        }
        return 'new';
    }

    if (totalVotes > 50) {
        let inflateVote = Math.ceil(Math.max(upvotesCount, downvotesCount) * 0.25);
        return [upvotesCount + inflateVote, downvotesCount + inflateVote, balance, rating()];
    }

    return [upvotesCount, downvotesCount, balance, rating.call(this)];
}