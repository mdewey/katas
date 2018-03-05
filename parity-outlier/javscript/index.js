const findOutlier = (numbers) => {
    const _data = numbers.reduce((_data, num) => {
        if (num % 2 ==0){
            _data.evenCount++
            _data.lastEven = num;
        } else {
            _data.oddCount++
            _data.tOdd = num;
        }
        return _data;
    }, {
        oddCount :0, 
        evenCount:0,
        lastOdd:0,
        lastEven:0,
    });
    return _data.oddCount === 1 ? _data.lastOdd : _data.lastEven;
}



console.log(findOutlier([1,2,1,1,1,1,1,1]))
console.log(findOutlier([2,2,2,1,2,2,2,2,2]))