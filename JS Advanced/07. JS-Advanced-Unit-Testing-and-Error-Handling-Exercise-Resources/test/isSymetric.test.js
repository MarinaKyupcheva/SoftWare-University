const isSymmetric = require('../isSymetric');
const {assert} = require('chai');

describe('Test is symetric functionallity', () => {
    it('Should pass when symetric array is provided', () => {
        let input = [1, 2, 3, 2, 1];
        let expectedResult = true;
        let actualResult = isSymmetric(input);
        assert.equal(actualResult, expectedResult);
    });

    it('Should fail when nonsymetric array is provided', () => {
        let input = [1, 2, 3, 2];
        let expectedResult = false;
        let actualResult = isSymmetric(input);
        assert.equal(actualResult, expectedResult);
    });

    it('Should return false for any input that isn’t of the correct type', () => {
        let expectedResult = false;

        assert.equal(isSymmetric(null), expectedResult);
        assert.equal(isSymmetric(undefined), expectedResult);
        assert.equal(isSymmetric({}), expectedResult);
        assert.equal(isSymmetric(''), expectedResult);
        assert.equal(isSymmetric(true), expectedResult);
        assert.equal(isSymmetric(false), expectedResult);
    });

    it('Should fail', () => {
        let actualtResult = (isSymmetric(['1', 1]));
        let expectedResult = false;
        assert.equal(actualtResult, expectedResult);
    });
});