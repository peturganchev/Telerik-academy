function printResult(args) {
  var searchedNumber = +args[2],
      numbers = args[1].split(' ').map(Number);

  return countTimes(numbers, searchedNumber);

  function countTimes(numArray, numberToSearch) {
    var i, len, count = 0;

    for (i = 0, len = numArray.length; i < len; i += 1) {
      if (numArray[i] === numberToSearch) {
        count += 1;
      }
    }
    return count;
  }
}


console.log(printResult(["8","6 21 6 -7856 73 73 -56","73"]));
