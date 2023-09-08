function solve(pieFlavours, firstTargetFlavour, secondTargetFlavour) {
    return pieFlavours.slice(pieFlavours.indexOf(firstTargetFlavour), pieFlavours.indexOf(secondTargetFlavour) + 1);
}

solve(['Pumpkin Pie',
    'Key Lime Pie',
    'Cherry Pie',
    'Lemon Meringue Pie',
    'Sugar Cream Pie'],
    'Key Lime Pie',
    'Lemon Meringue Pie'
);

solve(['Apple Crisp',
    'Mississippi Mud Pie',
    'Pot Pie',
    'Steak and Cheese Pie',
    'Butter Chicken Pie',
    'Smoked Fish Pie'],
    'Pot Pie',
    'Smoked Fish Pie'
);