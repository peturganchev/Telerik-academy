function pointInCircle(arguments) {
    var x = arguments[0];
    var y = arguments[1];
    var k = Math.sqrt(x * x + y * y);
    if (k <= 2) {
      console.log("yes " + k.toFixed(2));
  } else {
      console.log("no " + k.toFixed(2));
  }
}

pointInCircle(["-2", "0"]);
pointInCircle(["-1", "2"]);
