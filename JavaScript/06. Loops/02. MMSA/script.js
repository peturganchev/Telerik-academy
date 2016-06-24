function mMSA(arguments) {
    var min = +arguments[0],
        max = +arguments[0],
        sum = 0,
        avg = 0;
    for (var i = 0; i < arguments.length; i++) {
        if (min > +arguments[i]) {
            min = +arguments[i];
        } else if (max < +arguments[i]) {
            max = +arguments[i];
        }
        sum += +arguments[i];
    }
    avg = sum / arguments.length;
    console.log("min=" + min.toFixed(2));
    console.log("max=" + max.toFixed(2));
    console.log("sum=" + sum.toFixed(2));
    console.log("avg=" + avg.toFixed(2));
}

mMSA(['2', '5', '1']);
mMSA(['2', '-1', '4']);
