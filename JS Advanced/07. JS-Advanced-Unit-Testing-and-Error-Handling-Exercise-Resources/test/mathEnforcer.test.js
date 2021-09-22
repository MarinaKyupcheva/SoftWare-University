//const addFive = require('../addFive');
//const subtractTen = require('../subtractTen');
//const sum = require('../sum');
const mathEnforcer = require('../mathEnforcer');
const {assert} = require('chai');

describe('mathEnforcer', ()=> {
    describe('add', () => {
        it('return undefined', ()=> {
            assert.isUndefined(mathEnforcer.addFive('a'));
            assert.isNaN(mathEnforcer.addFive(NaN));
        });

        it('return properly value', ()=> {
            assert.equal(mathEnforcer.addFive(1), 6);
            assert.equal(mathEnforcer.addFive(-10), -5);
            assert.equal(mathEnforcer.addFive(1.5), 6.5);
            assert.equal(mathEnforcer.addFive(0), 5);
            assert.equal(mathEnforcer.addFive(-1), 4);
            assert.equal(mathEnforcer.addFive(-8.6), -3.5999999999999996);

        });
    });

    describe('subtractTen', () => {
        it('return undefined', ()=> {
            assert.isUndefined(mathEnforcer.subtractTen('a'));
            assert.isNaN(mathEnforcer.subtractTen(NaN));
        });

        it('return properly value', ()=> {
            assert.equal(mathEnforcer.subtractTen(1), -9);
            assert.equal(mathEnforcer.subtractTen(0), -10);
            assert.equal(mathEnforcer.subtractTen(10.5), 0.5);
            assert.equal(mathEnforcer.subtractTen(15), 5);
            assert.equal(mathEnforcer.subtractTen(-10.6), -20.6);
           

        });
    });

    describe('sum', () => {
        it('return undefined', ()=> {
            assert.isUndefined(mathEnforcer.sum('a', 1));
            assert.isUndefined(mathEnforcer.sum(2, 'a'));
           
        });

        it('return properly value', ()=> {
            assert.equal(mathEnforcer.sum(1, 1), 2);
            assert.equal(mathEnforcer.sum(0, -5), -5);
            assert.equal(mathEnforcer.sum(10.5, 1.5), 12);
            assert.equal(mathEnforcer.sum(-5, -5), -10);
            assert.equal(mathEnforcer.sum(-5.2, -5.3), -10.5);

        });
    });
});