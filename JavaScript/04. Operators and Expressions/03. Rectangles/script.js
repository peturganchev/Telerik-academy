function Rectangles(arguments) {
    var width = +arguments[0];
    var height = +arguments[1];
    var area = width * height;
    var perimeter = 2 * width + 2 * height;
    console.log(area.toFixed(2) + ' ' + perimeter.toFixed(2));
}

Rectangles(["2" , "3"]);
