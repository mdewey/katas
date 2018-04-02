console.log("starting")

const isEven = (x :string) => parseInt(x) % 2 == 0

const iqTest = (str :string) => {
    const numbers = str.split(" ")
    const test = [isEven(numbers[0]), isEven(numbers[1]), isEven(numbers[2])]
    const evenCount = test.filter(item => item).length    
    let rv = 1;
    if (evenCount >= 2){
        // find the first odd
        const needle = numbers.filter((v,i) => {
            return !isEven(v)
        })[0];
        rv += numbers.indexOf(needle);
    } else {
        const needle = numbers.filter((v,i) => {
            return isEven(v)
        })[0];
        rv += numbers.indexOf(needle);
    }
    return rv;
}

console.log(iqTest("2 4 7 8 10"))
console.log(iqTest("1 2 2"))