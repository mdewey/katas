// round to the closest number (/10)
// 27 => 30
// 12 => 10
// 35 => 40

// took the mod 10, 
// if mod < 5
    // count down to nearest 10s
// else 
    // count up
const closestMod = (num) =>{
    const ones = num % 10; 
    // 27 => 7
    // 15 => 5
    // 13 => 3
    let rv = 0;
    if (ones >= 5) {
        rv = num + ( 10 - ones);
    } else {
        rv = num - ones
    }
    return rv;
}


const closestMultiple10 = num => {
    /// Math.round
    // convert 27 => 2.7
    const dec = num / 10;
    const rounded = Math.round(dec);
    const rv = rounded * 10;
    return rv;
};


console.log(closestMultiple10(27));
console.log(closestMultiple10(13));
console.log(closestMultiple10(35));