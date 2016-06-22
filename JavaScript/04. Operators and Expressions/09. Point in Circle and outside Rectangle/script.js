function isItInside(arguments) {
    var x = arguments[0];
    var y = arguments[1];
    var c = Math.sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1));
    var circle = "";
    var rectangle = "";
    if (c <= 1.5) {
        circle = "inside circle";
    } else {
        circle = "outside circle";
    }

    if (x >= -1 & x <= 5 & y >= -1 & y <= 1) {
        rectangle = "inside rectangle";
    } else {
        rectangle = "outside rectangle";
    }
    console.log(circle + " " + rectangle);
}

isItInside(["2.5", "2"]);
isItInside(["0", "1"]);
isItInside(["2.5", "1"]);
isItInside(["1", "2"]);
