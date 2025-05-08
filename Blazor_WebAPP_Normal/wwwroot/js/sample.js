function callMethod(msg){
    DotNet.invokeMethodAsync('Blazor_WebAPP_Normal', 'CallFromJS', msg);
};

function Method1(instance) {
    instance.invokeMethodAsync("NewMethod").then(
        result => { alert(result); }
    );
};
