function repeat(n, action) {
  if (n === 0)
    return;

  action(n);

  repeat(n - 1, action);
}

repeat(3, console.log);
// 3
// 2
// 1