console.log("staring")

const logBase = function(n, base) {
    return Math.log(n) / Math.log(base);
};
const isPP = function (n) {
    // console.log({n})
    const rv = [];
    for (let i = 2; i <= n * 0.74; i++) {
        const value = logBase(n,i)
        if ((value - Math.floor(value)) < 0.0000001 ){
            rv.push(i)
            rv.push(Math.floor(value));
            break;
        }
    }
    
    if (rv.length === 0){
      return null;
    }
    return rv;
}

console.log(isPP(243)) //[3,2]