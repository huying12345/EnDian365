$(function(){$(window).scroll(function(){$(window).scrollTop()>=2e3?$("#backUp").show():$("#backUp").hide()}),$("#backUp").click(function(){$("html,body").animate({scrollTop:"0px"},500)})});