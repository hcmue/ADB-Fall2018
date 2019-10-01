var DATABASE = "/" + window.location.href.split("/")[3];

function getTasks() {
    $.ajax({
        url: DATABASE + "/_design/tasks/_view/tasks",
        success: function (data){
            var view = jQuery.parseJSON(JSON.stringify(data))
            var tasks = [];
            $(view.rows).each( function (index, item) {
                tasks.push (item.value);
            });
            displayTasks(tasks);
        }
     });
}

function displayTasks(tasks) {
    html = "<tr>";
    $(tasks).each( function (index, task) {
        var edit = "<input type='button' style='color: white; background-color: #b300b3;' value='Sửa' " +
            "onclick='editTask(" + JSON.stringify(task) + ")' />";  
        var save = "<input type='button' style='color: white; background-color: #b300b3;' value='Lưu' " +
            "onclick='saveTask(" + JSON.stringify(task) + ")' />"; 
        var del = "<input type='button' style='color: white; background-color: #b300b3;' value='Xóa' " +
            "onclick='deleteTask(" + JSON.stringify(task) + ")' />";
        html += "<tr>";
        html += "<td>" + task.hoten + " </td>";
        if(task.gender==1){
            html+="<td>Nam</td>"
        }
        else
        {
            html+="<td>Nữ</td>"
        }
        html += "<td>" + task.diachi + " </td>";
        html += "<td>" + task.dienthoai + " </td>";
        html += "<td>" + task.email + " </td>";
        html += "<td>" + edit + "</td>";
        html += "<td>" + save + "</td>";
        html += "<td>" + del + "</td>";
        html += "</tr>";
    });
    html += "</tr>";
    
    $('#tasks').empty();            
    $('#tasks').append(html);
}

function addTask() {
    var hoten = document.getElementById("hoten").value;
    if(document.getElementById("gioitinh").checked==true){
        var gender = document.getElementById("gioitinh").value;
    }
    else
    {
        var gender=document.getElementById("gioitinh1").value;
    }
    var diachi = document.getElementById("diachi").value;
    var dienthoai = document.getElementById("dienthoai").value;
    var email = document.getElementById("email").value;
    if (hoten && gender && diachi && dienthoai && email) {
        var task = {
            "hoten": hoten,
            "gender": gender,
            "diachi": diachi,
            "dienthoai": dienthoai,
            "email": email
        };

        $.ajax({
            type: "POST",
            url: DATABASE,
            contentType: "application/json",
            data: JSON.stringify(task),
            success: function () {
                getTasks();
            }
         });
    }
}

function editTask(task){
    document.getElementById("hoten").value = task.hoten;
    if(task.gender == 1)
    {
        document.getElementById("gioitinh").checked=true;
    }
    else 
    {
        document.getElementById("gioitinh1").checked=true;
    }
    document.getElementById("diachi").value = task.diachi;
    document.getElementById("dienthoai").value = task.dienthoai;
    document.getElementById("email").value = task.email;
}

function saveTask(task) {
    var hoten = document.getElementById("hoten").value;
    if(document.getElementById("gioitinh").checked==true){
        var gender = document.getElementById("gioitinh").value;
    }
    else
    {
        var gender= document.getElementById("gioitinh1").value;
    }
    var diachi = document.getElementById("diachi").value;
    var dienthoai = document.getElementById("dienthoai").value;
    var email = document.getElementById("email").value;
    if (hoten && gender && diachi && dienthoai && email) {
        task.hoten = hoten;
        task.gender = gender;
        task.diachi = diachi;
        task.dienthoai = dienthoai;
        task.email = email;

        $.ajax({
            type: "PUT",
            url: DATABASE + "/" + task._id,
            contentType: "application/json",
            data: JSON.stringify(task),
            success: function () {
                getTasks();
            }
         });
    }
    Add();
}

function deleteTask(task) {
    var doit = confirm("Bạn có thật sự muốn xóa '" + 
        task.hoten + "'?");
    if (doit) {
        $.ajax({
            type: "DELETE",
            url: DATABASE + "/" + task._id + "?rev=" + task._rev,
            success: function () {
                getTasks();
            }
         });
    }
}
function createView() {
    var view = {
       "language": "javascript",
       "views": {
           "tasks": {
               "map": "function(doc) {if (doc.hoten) {emit(doc.hoten, doc);}}"
           }
       }
    }
    $.ajax({
        type: "PUT",
        url: DATABASE + "/_design/tasks",
        contentType: "application/json",
        data: JSON.stringify(view)
     });
}