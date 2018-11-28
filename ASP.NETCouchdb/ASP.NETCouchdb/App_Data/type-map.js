function(doc) {
    if (doc.Loai == 'dienthoai') {
        emit(doc.Loai)
    }
}
