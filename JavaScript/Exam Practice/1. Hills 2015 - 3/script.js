// 1. Записваме масива.
// 2. Намираме върховете.
// 2.1. Върховете са по-големи от съседните неща.
// 3. Правим магии ( изваждаме индексите).
function solve(arguments) {
    let arr = arguments[0].split(' ').map(Number),
        currentCell,
        weAreHills = [],
        i,
        j = 0,
        k;
    weAreHills[j] = 0,
        stones = 0,
        maxStones = 0;
    for (i = 2; i < arr.length - 2; i++) {
        currentCell = +arr[i];
        if (currentCell > arr[i - 1] & currentCell > arr[i + 1]) {
            j += 1;
            weAreHills[j] = i;

        }
    }
    weAreHills[j + 1] = arr.length - 1;

    for (k = 0; k < weAreHills.length; k++) {
        stones = weAreHills[k + 1] - weAreHills[k];
        if (maxStones < stones) {
            maxStones = stones;
        }
    }
    console.log(maxStones);
}


solve(['5 1 7 4 8']);
solve(['5 1 7 6 3 6 4 2 3 8']);
