var SearchViewModel=function(){var e=this;this.search=ko.observableArray([]),this.pageIndex=ko.observable(1),this.pageCount=ko.observable(1),this.pageNumbers=ko.observableArray(),this.currengePage=ko.observable(1),this.refresh=function(){e.pageIndex()<1&&e.pageIndex(1),e.pageIndex()>e.pageCount()&&e.pageIndex(e.pageCount()),$.post("/api/PortalIPS/vwInfoCategory/GetvwInfoBySearchPage",{Series:jQuery("#Series").val(),CategoryID:jQuery("#CategoryID").val(),Author:jQuery("#Author").val(),keyword:jQuery("#keyword").val(),page:this.pageIndex,pageSize:5},function(a){e.search.removeAll(),e.pageNumbers.removeAll(),e.pageCount(Math.round(a.rows/10));for(var r=1;r<=e.pageCount();r++)e.pageNumbers.push({number:r,visible:r==e.pageIndex()?"on":""});for(var r in a.data)e.search.push(a.data[r])},"json")},this.first=function(){e.pageIndex(1),e.refresh()},this.next=function(){e.pageIndex(this.pageIndex()+1),e.refresh()},this.previous=function(){e.pageIndex(this.pageIndex()-1),e.refresh()},this.last=function(){e.pageIndex(this.pageCount()),e.refresh()},this.gotoPage=function(a){e.pageIndex(a.number),e.refresh()}};