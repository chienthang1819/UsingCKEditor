CKEDITOR.editorConfig = function (config) {
    config.toolbarGroups = [
        { name: 'tools' },
        { name: 'insert' },
        { name: 'links' },
        { name: 'basicstyles', groups: ['basicstyles', 'cleanup'] },
        { name: 'paragraph', groups: ['list', 'indent', 'blocks', 'align', 'bidi'] },
        //{ name: 'styles' },
        { name: 'document', groups: ['mode', 'document', 'doctools'] },
        { name: 'others' }
    ];
    
    // Remove some buttons provided by the standard plugins, which are not needed in the Standard(s) toolbar.
    config.removeButtons = 'Subscript,Superscript,Anchor';
    
    config.extraPlugins = 'markdown';
};
