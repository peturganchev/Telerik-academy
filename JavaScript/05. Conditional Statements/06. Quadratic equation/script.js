function qadraticEq(arguments) {
    var a = Number(+arguments[0]),
        b = Number(+arguments[1]),
        c = Number(+arguments[2]),
        sqrtPart = b * b - 4 * a * c,
        result1 = 0,
        result2 = 0;

    if ((b * b) < (4 * a * c)) {
        console.log("no real roots");
    } else {
        result1 = (-b + Math.sqrt(sqrtPart)) / (2 * a);
        result2 = (-b - Math.sqrt(sqrtPart)) / (2 * a);
        if (result1 < result2) {
            console.log("x1=" + result1.toFixed(2) + "; x2=" + result2.toFixed(2));
        } else if (result2 < result1) {
            console.log("x1=" + result2.toFixed(2) + "; x2=" + result1.toFixed(2));
        } else {
            console.log("x1=x2=" + result2.toFixed(2));
        }
    }
}

qadraticEq(["2","5","-3"]);
qadraticEq(["-1","3","0"]);
qadraticEq(["-0.5","4","-8"]);
qadraticEq(["5","2","8"]);
qadraticEq(["0.2","9.572","0.2"]);
