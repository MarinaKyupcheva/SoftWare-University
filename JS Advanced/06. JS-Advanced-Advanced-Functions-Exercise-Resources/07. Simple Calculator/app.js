function calculator() {
    let selectorOne;
    let selectorTwo;
    let result;

    return{
        init: (selector1, selector2, resultSelector) => {
            selectorOne = document.querySelector(selector1);
            selectorTwo = document.querySelector(selector2);
            result = document.querySelector(resultSelector);
        },

        add: () =>{
            result.value = Number(selectorOne.value) + Number(selectorTwo.value);
        },

        subtract: () => {
            result.value = Number(selectorOne.value) - Number(selectorTwo.value);
        }
    }

}
let calculate = calculator(); 
calculate.init('#num1', '#num2', '#result');

//let add = calculate.add;
//let subtract = calculate.subtract;
document.getElementById('sumButton').addEventListener('click', add);
document.getElementById('subtractButton').addEventListener('click', subtract);



