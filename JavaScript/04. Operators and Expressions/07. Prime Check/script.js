function prime(arguments) {
    var number = arguments[0];
    var currentNumber = 0;
    if (number <= 1) {
        console.log("false");
    } else if (number > 1) {
        for (var i = 2; i < number; i++) {
            if (number % i == 0) {
                currentNumber += 1;
            }
        }
        console.log((currentNumber > 0) ? "false" : "true");
    }
}

prime(["23"]);
prime(["-3"]);
prime(["0"]);
prime(["1"]);
