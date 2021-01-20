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
            function listHeroRank(heroList, person,persons) {
                var hl = '';
                var name = '';
                var id = '';
                for (var i = 0; i < heroList.length; i++) {
                   // console.log("keys ",Object.keys(heroList))
                   // console.log("obj vals ", Object.values(heroList));
                    id = heroList[i].heroId; //JSON.stringify(heroList[i].heroId);
                    console.log("id " + heroList[i].heroId);
                    console.log("id type" + typeof id);
                    console.log("person " + Object.keys(person));
                   // person.id = id;
                    console.log("length" + persons.length);
                    let obj = persons.find( o => o.id === id)
                    name = obj.name;
                    console.log("obj vals ", Object.values(obj));

                    console.log("name", name);
                                   
                    var rnk = JSON.stringify(heroList[i].rank);
                    console.log("rank  " + heroList[i].rank);
                    hl = hl + name + ' ' + rnk +',';
                }
                return hl;
            }
            var persons = [];
            $.each(this.options.people, function (i, person) {
               
                persons.push(person);
              
            });
            $.each(this.options.people, function (i, person) {
                var $tr = $('<tr>').data('person', person);
                var pref_cnt = person.preferences ? person.preferences.length : 0;
                $tr.append($('<td>').append(person.name));
                $tr.append($('<td>').append(person.side))
               // $tr.append($('<td>').append(person.preferences ? person.preferences.length : 0));
                $tr.append($('<td>').append(pref_cnt === 0 ? "The user did not select any preferences" : listHeroRank(person.preferences, person,persons) ));
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