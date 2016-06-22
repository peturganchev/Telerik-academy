function thirdDigit(arguments) {
    var number = parseInt(arguments[0]);
    var result = parseInt((number / 100) % 10);
    if (result == 7) {
        console.log(true);
    } else {
        console.log("false " + result);
    }
}
