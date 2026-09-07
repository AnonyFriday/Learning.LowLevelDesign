/*
    Consider with constructure has so many bool or params
    - If we want to create 1 object that setting the header only, the other is default, but the inconvenient here is that we have to 
      set the other params to default value to follow the constructor pattern
*/


using Builder.Before;

var report = new Report("Monthly Report", "This is the content of the monthly report.");
var reportIncludeCharts = new Report("Monthly Report", "This is the content of the monthly report.", true, false);
var reportCustomFooter = new Report("Monthly Report", "This is the content of the monthly report.", "Custom Footer");

