function planar(args) {
    var data = {},
        line1, line2, line3;

    function makeLine(x1, y1, x2, y2) {
        return {
            length: Math.sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))
        }
    }

    function isThereTriangle(firstLine, secondLine, thirdLine) {
        console.log(firstLine.length.toFixed(2));
        console.log(secondLine.length.toFixed(2));
        console.log(thirdLine.length.toFixed(2));
        if (firstLine.length + secondLine.length > thirdLine.length & secondLine.length + thirdLine.length > firstLine.length & thirdLine.length + firstLine.length > secondLine.length) {
            console.log('Triangle can be built');
        } else {
            console.log('Triangle can not be built');
        }
    }

    for (var i = 0; i < 12; i += 4) {
        data[i] = +args[i];
        data[i + 1] = +args[i + 1];
        data[i + 2] = +args[i + 2];
        data[i + 3] = +args[i + 3];
    }
    line1 = makeLine(data[0], data[1], data[2], data[3]);
    line2 = makeLine(data[4], data[5], data[6], data[7]);
    line3 = makeLine(data[8], data[9], data[10], data[11]);
    isThereTriangle(line1, line2, line3);
}

planar(['7','7','2','2',
'5', '6', '2', '2',
  '95', '-14.5', '0', '-0.123'
]);
