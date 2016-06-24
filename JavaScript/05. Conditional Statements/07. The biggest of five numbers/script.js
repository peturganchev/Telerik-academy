function qadraticEq(arguments) {
    var a = Number(+arguments[0]),
        b = Number(+arguments[1]),
        c = Number(+arguments[2]),
        d = Number(+arguments[3]),
        e = Number(+arguments[4]);
    console.log(Math.max(a, b, c, d, e));
}

qadraticEq(["5","0","1","-4","7"]);
