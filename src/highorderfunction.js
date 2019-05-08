function repeat(n, action, i = 0) {
  if (i === n)
    return;

  action(i);

  repeat(n, action, ++i);
}

repeat(3, console.log);
// 0
// 1
// 2