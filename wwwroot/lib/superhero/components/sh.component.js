; (function ($) {
    // Override _createHelper
    var shUuid = 'sh-uuid-';
    $.widget("sh.component", {
        options: {
        },
        __createId: function () {
            $(this.element).attr('id', shUuid + this.uuid);
        },
        _create: function () {
            this.__createId();
            this._createHelper();
        },
        _destroy: function () {
            this.element.removeClass().text('').remove();
        },
        _createHelper: function () {},
        setOptions: function (options) {
            var that = this;
            $.each(options, function (key, value) {
                that._setOption(key, value);
            });
            return this;
        },
        id: function () { return shUuid + this.uuid }
    });
})(jQuery);