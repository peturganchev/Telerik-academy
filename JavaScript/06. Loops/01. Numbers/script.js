function numbers(arguments) {
    var N = arguments[0],
        result = "";
    for (var i = 0; i < N; i++) {
        result += (i + 1) + " ";
    }
    console.log(result);
}

numbers(["1"]);
numbers(["5"]);
numbers(["100"]);
