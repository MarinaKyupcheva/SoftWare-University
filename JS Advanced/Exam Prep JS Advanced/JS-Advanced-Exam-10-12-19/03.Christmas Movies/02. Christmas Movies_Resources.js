const {describe} = require('mocha');
const {assert, expect} = require('chai');

class ChristmasMovies {
    constructor() {
        this.movieCollection = [];
        this.watched = {};
        this.actors = [];
    }

    buyMovie(movieName, actors) {
        let movie = this.movieCollection.find(m => movieName === m.name);
        let uniqueActors = new Set(actors);

        if (movie === undefined) {
            this.movieCollection.push({ name: movieName, actors: [...uniqueActors] });
            let output = [];
            [...uniqueActors].map(actor => output.push(actor));
            return `You just got ${movieName} to your collection in which ${output.join(', ')} are taking part!`;
        } else {
            throw new Error(`You already own ${movieName} in your collection!`);
        }
    }

    discardMovie(movieName) {
        let filtered = this.movieCollection.filter(x => x.name === movieName)

        if (filtered.length === 0) {
            throw new Error(`${movieName} is not at your collection!`);
        }
        let index = this.movieCollection.findIndex(m => m.name === movieName);
        this.movieCollection.splice(index, 1);
        let { name, _ } = filtered[0];
        if (this.watched.hasOwnProperty(name)) {
            delete this.watched[name];
            return `You just threw away ${name}!`;
        } else {
            throw new Error(`${movieName} is not watched!`);
        }

    }

    watchMovie(movieName) {
        let movie = this.movieCollection.find(m => movieName === m.name);
        if (movie) {
            if (!this.watched.hasOwnProperty(movie.name)) {
                this.watched[movie.name] = 1;
            } else {
                this.watched[movie.name]++;
            }
        } else {
            throw new Error('No such movie in your collection!');
        }
    }



    favouriteMovie() {
        let favourite = Object.entries(this.watched).sort((a, b) => b[1] - a[1]);
        if (favourite.length > 0) {
            return `Your favourite movie is ${favourite[0][0]} and you have watched it ${favourite[0][1]} times!`;
        } else {
            throw new Error('You have not watched a movie yet this year!');
        }
    }

    mostStarredActor() {
        let mostStarred = {};
        if (this.movieCollection.length > 0) {
            this.movieCollection.forEach(el => {
                let { _, actors } = el;
                actors.forEach(actor => {
                    if (mostStarred.hasOwnProperty(actor)) {
                        mostStarred[actor]++;
                    } else {
                        mostStarred[actor] = 1;
                    }
                })
            });
            let theActor = Object.entries(mostStarred).sort((a, b) => b[1] - a[1]);
            return `The most starred actor is ${theActor[0][0]} and starred in ${theActor[0][1]} movies!`;
        } else {
            throw new Error('You have not watched a movie yet this year!')
        }
    }
}


describe('ChristmasMovies Tests', () => {
    let christmas = '';
    beforeEach(() => {
        christmas = new ChristmasMovies();
    });

    //buy
    it('buyMovie should add correct', () => {
        assert.equal(christmas.buyMovie('Harry Potter', ['Rupert Grint', 'Dilun Bed']),
            `You just got Harry Potter to your collection in which Rupert Grint, Dilun Bed are taking part!`)
    });
    it('buyMovie should throw Error', () => {
        christmas.buyMovie('Harry Potter', ['Rupert Grint']);
        assert.throws(() => christmas.buyMovie('Harry Potter', 'Rupert Grint'),
            `You already own Harry Potter in your collection!`)
    });
    it('buyMovie should add just one actor', () => {
        assert.equal(christmas.buyMovie('Harry Potter', ['Rupert Grint', 'Rupert Grint']),
            `You just got Harry Potter to your collection in which Rupert Grint are taking part!`)
    });

    it('discardMovie should throw Error', () => {
        assert.throws(() => christmas.discardMovie('Harry Potter'), `Harry Potter is not at your collection!`);
    });
    it('discardMovie should remove movie', () => {
        christmas.buyMovie('Harry Potter', ['Rupert Grint', 'Dilun Bed']);
        christmas.watchMovie('Harry Potter');
        assert.equal(christmas.discardMovie('Harry Potter'), `You just threw away Harry Potter!`)
    });
    it('discardMovie should throw Error', () => {
        christmas.buyMovie('Harry Potter', ['Rupert Grint', 'Dilun Bed']);
        assert.throws(() => christmas.discardMovie('Harry Potter'), `Harry Potter is not watched!`);
    });

    it('watchMovie should throw Error', () => {
        assert.throws(() => christmas.watchMovie('Harry Potter'), 'No such movie in your collection!')
    })
    it('watchMovie should increase watched movie', () => {
        christmas.buyMovie('Harry Potter', ['Rupert Grint']);
        christmas.watchMovie('Harry Potter');
        christmas.watchMovie('Harry Potter');
        christmas.watchMovie('Harry Potter');
        assert.equal(christmas.watched['Harry Potter'], 3)
    })

    it('favouriteMovie should return higest watched movie', () => {
        christmas.buyMovie('Harry Potter', ['Rupert Grint', 'Dilun Bed']);
        christmas.buyMovie('Last Christmas', ['Emilia Clarke', 'Henry Golding']);
        christmas.watchMovie('Harry Potter');
        christmas.watchMovie('Harry Potter');
        assert.equal(christmas.favouriteMovie(),
            `Your favourite movie is Harry Potter and you have watched it 2 times!`)
    });
    it('favouriteMovie should throw Error', () => {
        assert.throws(() => christmas.favouriteMovie(), 'You have not watched a movie yet this year!');
    })
    it('favouriteMovie should throw Error', () => {
        assert.throws(() => christmas.favouriteMovie(), 'You have not watched a movie yet this year!');
    })

    it('mostStarredActor should return actor', () => {
        christmas.buyMovie('Home Alone', ['Macaulay Culkin', 'Joe Pesci', 'Daniel Stern']);
        christmas.buyMovie('Harry Potter', ['Rupert Grint', 'Macaulay Culkin']);
        christmas.watchMovie('Home Alone');
        assert.equal(christmas.mostStarredActor(), 'The most starred actor is Macaulay Culkin and starred in 2 movies!')
    });

    it('mostStarredActor should throw Error', () => {
        assert.throws(() => christmas.mostStarredActor(), 'You have not watched a movie yet this year!')
    });
})

// watchMovie(movieName) {
//     let movie = this.movieCollection.find(m => movieName === m.name);
//     if (movie) {
//         if (!this.watched.hasOwnProperty(movie.name)) {
//             this.watched[movie.name] = 1;
//         } else {
//             this.watched[movie.name]++;
//         }
//     } 
// }




let christmas = new ChristmasMovies();
christmas.buyMovie('Home Alone', ['Macaulay Culkin', 'Joe Pesci', 'Daniel Stern']);
christmas.buyMovie('Home Alone 2', ['Macaulay Culkin']);
christmas.buyMovie('Last Christmas', ['Emilia Clarke', 'Henry Golding']);
christmas.buyMovie('The Grinch', ['Benedict Cumberbatch', 'Pharrell Williams']);
christmas.watchMovie('Home Alone');
christmas.watchMovie('Home Alone');
christmas.watchMovie('Home Alone');
christmas.watchMovie('Home Alone 2');
christmas.watchMovie('The Grinch');
christmas.watchMovie('Last Christmas');
christmas.watchMovie('Home Alone 2');
christmas.watchMovie('Last Christmas');
christmas.discardMovie('The Grinch');
christmas.favouriteMovie();
christmas.mostStarredActor();

module.exports = ChristmasMovies;