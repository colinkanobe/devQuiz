; (function ($) {
    $.extend(true, window, {
        Sh: {
            Ajax: {
                execute: function (options) {
                    var params = options.type === 'POST'
                        ? JSON.stringify(options.parameters)
                        : options.parameters;

                    $.ajax({
                        async: !options.sync,
                        cache: options.cache,
                        url: options.url,
                        type: options.type,
                        contentType: "application/json",
                        data: params,
                        success: function (data) {
                            options.callback(data);
                        },
                        error: function (xhr, status, err) {
                            options.callback({
                                success: false,
                                error: err,
                                status: status
                            });
                        },
                        complete: function (xhr, status) {
                            if (options.completed) {
                                options.completed();
                            }
                        }
                    });
                }
            }
        }
    });
})(jQuery);