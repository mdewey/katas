const getLower = (x, y) => x < y
    ? x
    : y;

Array.prototype.count = function (condition) {
    const instances = this.filter(condition);
    return instances.length;
}

var nbrOfLaps = function (x, y) {
    const placesBeen = [x, y];
    let bob = x;
    let steve = y;
    let target = 0;
    while (target == 0) {
        bob += x;
        steve += y;
        placesBeen.push(bob)
        placesBeen.push(steve)
        const lowest = getLower(bob, steve);
        const count = placesBeen.count((item) => item == lowest);
        if (count > 1) {
            target = lowest;
        }
        console.log({count, placesBeen});

    }
    return [target/x, target/y];
}

console.log(nbrOfLaps(4, 6));
