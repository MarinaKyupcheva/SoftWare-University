function solve() {
    if (arguments[0].dizziness === true){
        arguments[0].levelOfHydrated += Number(arguments[0].weight) * Number(arguments[0].experience) * 0.1;
        arguments[0].dizziness = false;
    }
    return arguments[0];
}
