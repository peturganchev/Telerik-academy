function multiplicationSign(arguments) {
    var a = arguments[0],
        b = arguments[1],
        c = arguments[2];
    if (a > 0 && b > 0 && c > 0) {
        console.log("+");
    } else if (a == 0 || b == 0 || c == 0) {
        console.log("0");
    } else if (a < 0 && b < 0 && c < 0) {
        console.log("-");
    } else if (a > 0 && b > 0 && c < 0) {
        console.log("-");
    } else if (a > 0 && b < 0 && c > 0) {
        console.log("-");
    } else if (a < 0 && b > 0 && c > 0) {
        console.log("-");
    } else if (a < 0 && b < 0 && c > 0) {
        console.log("+");
    } else if (a < 0 && b > 0 && c < 0) {
        console.log("+");
    } else if (a > 0 && b < 0 && c < 0) {
        console.log("+");
    }
}

multiplicationSign(["5","2","2"]);
multiplicationSign(["-2","-2","2"]);
multiplicationSign(["-2","4","3"]);
multiplicationSign(["0","-2.5","4"]);
multiplicationSign(["-1","-0.5","-5.1"]);
