function SaveInfo(
    //element, HRRFNumber, Purpose, ProjectName, DemandType, Grade, RoleRequired, ExpFrom, ExpTo, ReservationStatus, ServiceLine, AccountNamewithID, EnagagementType, NoofPositions, PrimarySkills, PrimRating, SecondarySkills, SecondRating, Domain
    //           , JobDescription, ResourceExpectedDate, StartDateofAssignment, EndDateofAssignment, LocationType, OffshoreLocation, ClientInterview
               ) {
    debugger
    if ($('#HRRFNumber').val().length == 0 || $('#Purpose').val().length == 0 || $('#Grade').val().length == 0
            || $('#Role').val().length == 0 || $('#ExpFrom').val().length == 0 || $('#ExpTo').val().length == 0
           || $('#Projects').val().length == 0 || $('#Practice').val().length == 0 || $('#EngagementType').val().length == 0
            || $('#PrimarySkills').val() != null && $('#PrimarySkills').val().length == 0 || $('#JobDescription').val().length == 0
            || $('#ExpectedStart').val().length == 0 || $('#ExpectedEnd').val().length == 0
            || $('#LocationType').val().length == 0) {

        alert('Please select all required fields');
        return false;
    }
    else {
        //project info
        //if ($('#Purpose').val() == "Project") {
        //    if ($('#Projects').val().length == 0 || $('#Practice').val().length == 0 || $('#EngagementType').val().length == 0) {
        //        alert('Please select all required fields');
        //        return false;
        //    }
        var HRRFNumber = $('#HRRFNumber').val()
        var Purpose = $('#Purpose').val()
        var ProjectName = $('#Projects').val()
        var DemandType = $('#DemandType').val()
        var Grade = $('#Grade').val()
        var RoleRequired = $('#Role').val()
        var ExpFrom = $('#ExpFrom').val()
        var ExpTo = $('#ExpTo').val()
        //var ReservationStatus = $('#ReservationStatus').val()
        //var ServiceLine = $('#ServiceLine').val()
        //var AccountNamewithID = $('#AccountNameWithID').val()
        var EnagagementType = $('#EngagementType').val()
        var NoofPositions = $('#NoofPositions').val()
        var Practice = $('#Practice').val()
        //skills
        var Domain = $('#Domain').val()
        var JobDescription = $('#JobDescription').val()

        // timeline
        //var ResourceExpectedDate = $('#ExpectedDate').val()
        var StartDateofAssignment = $('#ExpectedStart').val()
        var EndDateofAssignment = $('#ExpectedEnd').val()
        var LocationType = $('#LocationType').val()
        var OffshoreLocation = $('#OffShoreLocation').val()
        var ClientInterview = $('#Clientint').val()
        var element = this;

        SubmitData()
        $.ajax({
            url: "/CreateHRRF/SaveInfo",
            type: "POST",
            async: false,

            data: JSON.stringify({
                'HRRFNumber': HRRFNumber, 'Purpose': Purpose, 'ProjectName': ProjectName, 'DemandType': DemandType, 'Grade': Grade, 'RoleRequired': RoleRequired, 'ExpFrom': ExpFrom, 'ExpTo': ExpTo,
                'EnagagementType': EnagagementType, 'NoofPositions': NoofPositions, 'Practice': Practice, 'Domain': Domain,
                'JobDescription': JobDescription, 'StartDateofAssignment': StartDateofAssignment, 'EndDateofAssignment': EndDateofAssignment,
                'LocationType': LocationType, 'OffshoreLocation': OffshoreLocation, 'ClientInterview': ClientInterview
            }),
            dataType: "json",
            traditional: true,
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                if (data.status == "Success") {
                    alert("Saved successfully");
                    // $(element).closest("form").submit();
                    return false;
                }
                else if (data.status == "HRRHConfirm") {
                    alert("Please generate HRRH Number!");
                    return false;
                    //$(element).closest("form").submit();
                }
                else {
                    alert("Error occurs on the Database level!");
                }
            },
            error: function () {
                alert("An error has occured!!!");
            }
        });
    }
}

function SubmitData() {

    var PrimarySkills = '';
    var SecondarySkills = '';
    var HRRFNumber = $('#HRRFNumber').val();
       $("#PrimarySkillsGrid tr").each(function () {
        var x = $(this).attr('id');
        if (x != undefined) {
            var pID = x.split('_')[1] + ":" + $(this).find(".primary").attr('text');
            PrimarySkills = PrimarySkills + pID + ';';
        }

    });
    $("#SecondarySkillsgrid tr").each(function () {
        var x = $(this).attr('id');
        if (x != undefined) {
            var SID = x.split('_')[1] + ":" + $(this).find(".secondary").attr('text');
            SecondarySkills = SecondarySkills + SID + ';';
        }

    });

    // var url = "/CreateHRRF/SubmitHRRFSkills/";
    $.ajax({

        url: '@Url.Action("SubmitHRRFSkills", "CreateHRRF")',
        data: { PrimarySkills: PrimarySkills, SecondarySkills: SecondarySkills, HRRFNumber: HRRFNumber },
        cache: false,
        type: "POST",
        dataType: "JSON",
        success: function (HRRFSkills) {
        },
        error: function (HRRFSkills) {

        }
    });

}


