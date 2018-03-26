console.log("starting")

function divisors(integer) {
    const rv = [];
    const top = Math.ceil(integer / 2);
    for (let i = 2; i <= top; i++) {
        if (integer % i === 0) {
            rv.push(i)
        }
    }
    return rv.length === 0
        ? `${integer} is prime`
        : rv;
};
console.log(divisors(12))
console.log(divisors(25))
console.log(divisors(13))