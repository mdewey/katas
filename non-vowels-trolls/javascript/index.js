function disemvowel(str) {
    const x = str.split("").reduce((acc, item) => {
        if ("aeiouAEIOU".indexOf(item) >=0){
            return acc;
        } else {
            return acc += item;
        }
    },"")
    return x;
  }

