
$("#formSubmission").click(function () {
    //Calculate final grade
    finalGrade = $('#assignments').val() * .50 + $('#groupproject').val() * .10 +
        $('#quizzes').val() * .10 + $('#midterm').val() * .10 + $('#final').val() * .10 + $('#intex').val() * .10

    //If statements determining letter grade
    if (finalGrade >= 94) {
        letterGrade = 'A'
    }
    else if (finalGrade >= 90) {
        letterGrade = 'A-'
    }
    else if (finalGrade >= 87) {
        letterGrade = 'B+'
    }
    else if (finalGrade >= 84) {
        letterGrade = 'B'
    }
    else if (finalGrade >= 80) {
        letterGrade = 'B-'
    }
    else if (finalGrade >= 77) {
        letterGrade = 'C+'
    }
    else if (finalGrade >= 74) {
        letterGrade = 'C'
    }
    else if (finalGrade >= 70) {
        letterGrade = 'C-'
    }
    else if (finalGrade >= 67) {
        letterGrade = 'D+'
    }
    else if (finalGrade >= 64) {
        letterGrade = 'D'
    }
    else if (finalGrade >= 60) {
        letterGrade = 'D-'
    }
    else{
        letterGrade = 'E'
    }

        //Clean data and display
    Math.round(finalGrade*100)/100
    $('#potentialGrade').text(finalGrade + " Your letter Grade is: "+letterGrade);
});

