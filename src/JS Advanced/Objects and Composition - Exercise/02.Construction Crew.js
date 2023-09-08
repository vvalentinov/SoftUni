function solve(input) {
    if (input.dizziness == true) {
        let amount = 0.1 * input.weight * input.experience;
        input.levelOfHydrated += amount;
        input.dizziness = false;
    }

    return input;
}

solve({ weight: 80, experience: 1, levelOfHydrated: 0, dizziness: true });
solve({ weight: 120, experience: 20, levelOfHydrated: 200, dizziness: true });
solve({ weight: 95, experience: 3, levelOfHydrated: 0, dizziness: false });