$('#tt').datagrid({
    title: 'DataGrid - GroupView',
    width: 500,
    height: 250,
    rownumbers: true,
    remoteSort: false,
    nowrap: false,
    fitColumns: true,
    url: 'datagrid_data.json',
    columns: [[
			{ field: 'productid', title: 'Product ID', width: 100, sortable: true },
			{ field: 'listprice', title: 'List Price', width: 80, align: 'right', sortable: true },
			{ field: 'unitcost', title: 'Unit Cost', width: 80, align: 'right', sortable: true },
			{ field: 'attr1', title: 'Attribute', width: 150, sortable: true },
			{ field: 'status', title: 'Status', width: 60, align: 'center' }
		]],
    groupField: 'productid',
    view: groupview,
    groupFormatter: function (value, rows) {
        return value + ' - ' + rows.length + ' Item(s)';
    }
});
