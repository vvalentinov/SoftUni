function days(a, b) {
    console.log(new Date(b, a, 0).getDate());
}

days(2, 2021);
days(1, 2012);