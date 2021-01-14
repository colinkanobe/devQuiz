; (function ($) {
    $.widget("sh.heroTable", $.sh.component, {
        options: {
            people: []
        },
        __initializeTable: function () {
            $(this.element).removeClass().empty()
                .addClass('table table-bordered table-sm table-hover sh-table');

            var $thead = $('<thead>').appendTo($(this.element)),
                $theadRow = $('<tr>').appendTo($thead);
            var $tbody = $('<tbody>').appendTo($(this.element));
            $('<th>').html('User').appendTo($theadRow);
            $('<th>').html('Side').appendTo($theadRow);
            $('<th>').html('Preferences').appendTo($theadRow);
        },
        __populateTable: function () {
            var that = this;
            $.each(this.options.people, function (i, person) {
                var $tr = $('<tr>').data('person', person);
                $tr.append($('<td>').append(person.name));
                $tr.append($('<td>').append(person.side));
                $tr.append($('<td>').append(person.preferences ? person.preferences.length : 0));
                $(that.element).append($tr);
            });
        },
        __bindEvents: function () {
            var that = this;
            $(this.element).on('click', 'tbody tr', function () {
                var person = $(this).data('person');
                that._trigger(':edit', null, [person]);
            }); 
        },
        _createHelper: function () {
            this.__initializeTable();
            this.__populateTable();
            this.__bindEvents();
        }
    });
})(jQuery);