/*
 *  crosshair.js - v0.1.0
 *  Crosshair any dom element.
 *  https://github.com/eschmar/crosshair
 *
 *  @author:   Marcel Eschmann, @eschmar
 *  @license:  MIT License
 */
;
(function (e, i, t, s) {
    var r, n, h, o, a, l, c = {
        scale: 1,
        wrap: true,
        legend: true,
        marker: '',
        callback: function (e) {
            console.log(e.pct)
        }
    };

    function d(i, t) {
        this.options = e.extend({}, c, t);
        this._defaults = c;
        if (this.options.wrap) {
            e(i).wrap('<div class="crosshair"></div>');
            this.element = e(i).parent()
        } else {
            this.element = e(i).addClass("crosshair")
        }
        this.coords = {
            x: null,
            y: null
        };
        this.live_coords = {
            x: null,
            y: null
        };
        this.pct = {
            x: null,
            y: null
        };
        this.live_pct = {
            x: null,
            y: null
        };
        this.init()
    }
    d.prototype = {
        init: function () {
            var e = this;
            this.spawnCrosshair();
            this.element.hover(function () {
                e.element.find(".hair, .crosshair-legend").show()
            }, function () {
                e.element.find(".hair, .crosshair-legend").hide()
            })
        },
        spawnCrosshair: function () {
            this.element.append('<div class="hair hair-vertical"></div>');
            this.element.append('<div class="hair hair-horizontal"></div>');
            this.initCrosshair()
        },
        initCrosshair: function () {
            var i = this;
            e(this.element).on("mousemove touchmove", function (e) {
                var t, s, r;
                s = $('#content').clientX;
                r = $('#content').clientY;
                i.live_coords.x = s;
                i.live_coords.y = r;
                i.element.find(".hair.hair-horizontal").css("top", i.live_coords.y);
                i.element.find(".hair.hair-vertical").css("left", i.live_coords.x);
                i.live_pct.x = (100 / i.element.width() * i.live_coords.x).toFixed(2);
                i.live_pct.y = (100 / i.element.height() * i.live_coords.y).toFixed(2);
                i.updateLegend();
                e.stopPropagation()
            });
            this.element.click(function (e) {
                i.setMarker();
                e.stopPropagation()
            })
        },
        updateLegend: function () {
            if (!this.options.legend) {
                this.element.find(".crosshair-legend").remove();
                this.legend = null;
                return
            }
            if (!this.legend) {
                this.element.append('<div class="crosshair-legend"></div>');
                this.legend = this.element.find(".crosshair-legend")
            }
            this.legend.html("X: " + this.live_coords.x + "px, Y: " + this.live_coords.y + "px")
        },
        setMarker: function () {
            if (this.element.find(".crosshair-marker").length > 1) {
                this.element.find(".crosshair-marker").remove();
                this.marker = null
            } else if (!this.marker && this.element.find(".crosshair-marker").length === 1) {
                this.marker = this.element.find(".crosshair-marker")
            }
            if (!this.marker) {
                this.element.append(this.options.marker);
                this.marker = this.element.find(".crosshair-marker")
            }
            this.coords.x = this.live_coords.x;
            this.coords.y = this.live_coords.y;
            this.pct.x = (100 / this.element.width() * this.coords.x).toFixed(2);
            this.pct.y = (100 / this.element.height() * this.coords.y).toFixed(2);
            var e = this.marker.width();
            var i = this.marker.height();
            this.marker.css("left", this.coords.x - e / 2);
            this.marker.css("top", this.coords.y - i / 2);
            this.options.callback(this)
        }
    };
    e.fn["crosshair"] = function (i, scale) {
        return this.each(function () {
            if (!e.data(this, "crosshair")) {
                e.data(this, "crosshair", new d(this, i))
            }
        })
    }
})(jQuery, window, document);
