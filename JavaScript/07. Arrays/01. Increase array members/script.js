function makeArray(arguments) {
    var input = +arguments[0],
        i,
        arr = new Array(input);
    for (i = 0; i < arr.length; i++) {
        arr[i] = i * 5;
        console.log(arr[i]);
    }
}

makeArray(["5"]);
