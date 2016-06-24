function solve(args) {
    var number = +args[0],
        units = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'],
        unique = ['eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'],
        tenths = ['ten', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'],
        result;

    if (number < 10) {
        result = units[number];
    } else if (number < 100) {
        if (number >= 11 && number <= 19) {
            result = unique[number % 10 - 1];
        } else if (number % 10 === 0) {
            result = tenths[Math.floor(number / 10) - 1];
        } else {
            result = tenths[Math.floor(number / 10) - 1] + ' ' + units[number % 10];
        }
    } else {
        result = units[Math.floor(number / 100)] + ' hundred';
        breakme: if (number % 100 === 0) {} else
        if (number % 100 >= 11 && number % 100 <= 19) {
            result += ' and ' + unique[number % 10 - 1];
        } else if (number % 10 === 0) {
            result += ' and ' + tenths[(Math.floor(number / 10)) % 10 - 1];
        } else if ((Math.floor(number / 10)) % 10 === 0) {
            result += ' and ' + units[number % 10];
        } else {
            result += ' and ' + tenths[(Math.floor(number / 10)) % 10 - 1] + ' ' + units[number % 10];
        }
    }

    String.prototype.capitalizeFirstLetter = function() {
        return this.charAt(0).toUpperCase() + this.slice(1);
    }

    console.log(result.capitalizeFirstLetter());
}

solve(["245"]);
solve(["4"]);
solve(["15"]);
solve(["666"]);
