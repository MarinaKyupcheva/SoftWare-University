function createSortedList(list) {
    let result = [];
    function add(x) {
        result.push(x);
        this.size++;
        result.sort((a, b)=> a-b);

    }

    function remove(index) {
        if(index >= 0 && index < result.length){
            result.splice(index, 1);
            this.size--;
        }
    }

    function get(index) {
        if(index >= 0 && index < result.length){
            return result[index];
        }
    }
    return{
        size: 0,
        add,
        remove,
        get,
        
    }
}
let list = createSortedList();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1));
list.remove(1);
console.log(list.get(1));