
$( "div.new" ).on( "click", function() {
  var $container = $( "div.YoutubeNew" ).replaceWith( $('<div class="showYoutube"> @Html.Partial("YoutubeNew", @Model.Content)</div>') );
});

$( "div.Pop" ).on( "click", function() {
  var $container = $( "div.YoutubeNew" ).replaceWith( $('<div class="showYoutube"> @Html.Partial("YoutubePop", @Model.Content)</div>') );
});

$( "div.Rec" ).on( "click", function() {
  var $container = $( "div.YoutubeNew" ).replaceWith( $('<div class="showYoutube"> @Html.Partial("YoutubeRec", @Model.Content)</div>') );
});

