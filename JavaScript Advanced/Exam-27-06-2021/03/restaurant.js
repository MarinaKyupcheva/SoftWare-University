class Restaurant {
    constructor(budgetMoney) {
        this.budgetMoney = +budgetMoney;
        this.menu = {};
        this.stockProducts = {}
        this.history = []
    }
    loadProducts(products) {  
        let messageLog = []
        for (let entry of products) {
            entry = entry.split(' ')
        
            let price = +entry.pop()
            let quantity = +entry.pop()
            let product = entry.join(' ')
            if (this.budgetMoney - price >= 0) {
                if (this.stockProducts[product]) this.stockProducts[product] += quantity
                else this.stockProducts[product] = quantity
                this.budgetMoney -= price
                messageLog.push( `Successfully loaded ${quantity} ${product}`)
            } else {
                messageLog.push(`There was not enough money to load ${quantity} ${product}`)
            }
        }
      
        this.history = [...this.history, ...messageLog]
        return this.history.join('\n')  
        
    }
    addToMenu(meal, neededIngs, price) {  
        if (!this.menu[meal]) {
            this.menu[meal] = [neededIngs, +price]
            return `Great idea! Now with the ${meal} we have ${Object.keys(this.menu).length} meal on the menu, other ideas?` //? no effect //TEST 6 ERROR
        } else return `The ${meal} is already in our menu, try something different.`
 
    }
    showTheMenu() {
        let toPrint = []
        for (let key of Object.keys(this.menu)) {
            toPrint.push(`${key} - $ ${this.menu[key][1]}`) 
        }
        if (!toPrint.length) return ('Our menu is not ready yet, please come later...')
        else {return toPrint.join('\n')}
 
    }
    makeTheOrder(meal) {
        if (!this.menu[meal]) return (`There is not ${meal} yet in our menu, do you want to order something else?`)
           
        let ingredientsNeeded = this.menu[meal][0]  
        for (let item of ingredientsNeeded) { 
            item = item.split(' ')
            let quantity = +item.pop()
            let product = item.join(' ')
          
            if (this.stockProducts[product] < quantity || !this.stockProducts[product]) {
                return (`For the time being, we cannot complete your order (${meal}), we are very sorry...`) // test 15
            }
        }
 
        for (let item of ingredientsNeeded) {
            item = item.split(' ')
            let quantity = +item.pop()
            let product = item.join(' ')
            this.stockProducts[product] -= quantity
        } this.budgetMoney += this.menu[meal][1]
        return (`Your order (${meal}) will be completed in the next 30 minutes and will cost you ${this.menu[meal][1]}.`) //test 13 pass
    }
}