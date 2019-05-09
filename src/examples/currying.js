function volume(length) {
  return function(width) {
    return function(height) {
      return length * width * height;
    };
  };
}

volume(2)(3)(4); // 24