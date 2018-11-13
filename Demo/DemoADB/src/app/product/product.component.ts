import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { AngularFirestore, AngularFirestoreCollection } from 'angularfire2/firestore';
import { FormControl, FormGroup, FormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

export interface TypeProduct {
  value: string;
  viewValue: string;
}
class Product {
  productID: string;
  name: string;
  price: number;
  manufactures: string;
  image: string;
  dExpire: Date;
  dManufacture: Date;
  type: string;
}
@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  public products: Observable<any[]>;
  public itemCollection: AngularFirestoreCollection<Product>;
  public searchCollection: AngularFirestoreCollection<Product>;
  temp: Product = new Product();
  srcImg = '';
  selectType = 'None';
  // List Type of Product Mock
  typeProducts: TypeProduct[] = [
    { value: 'type-01', viewValue: 'Drink Water' },
    { value: 'type-02', viewValue: 'Alcohol' },
    { value: 'type-03', viewValue: 'Wine' },
    { value: 'type-04', viewValue: 'Bakery' },
    { value: 'type-05', viewValue: 'Beer' },
  ];
  // Form Control
  productProfile = new FormGroup({
    nameProduct: new FormControl(''),
    priceProduct: new FormControl(''),
    manuProd: new FormControl(''),
    imgProd: new FormControl(''),
    dManu: new FormControl(''),
    dExpire: new FormControl(''),
    typeProduct: new FormControl('')
  });
  // File Image Select
  selectedFile: File;

  constructor(public db: AngularFirestore, private http: HttpClient) {
    this.itemCollection = this.db.collection('items');
    this.searchCollection = this.db.collection('items', ref => ref.where('name', '==', 'Bánh Mì Kẹp Thịt'));
    this.products = this.itemCollection.snapshotChanges().pipe(
      map(action => action.map(a => {
        const data = a.payload.doc.data() as Product;
        const id = a.payload.doc.id;
        return { id, ...data };
      }))
    );
  }
  uploadFile(event) {

  }
  onFileSelected(event) {
    this.selectedFile = <File>event.target.files[0];
    this.srcImg = this.selectedFile.name;
  }
  onSelectItem(prod: Product) {
    this.srcImg = prod.image;
    this.selectType = prod.type;
    this.productProfile.patchValue({
      nameProduct: prod.name,
      priceProduct: prod.price,
      manuProd: prod.manufactures,
      dManu: prod.dManufacture,
      dExpire: prod.dExpire
    });
  }
  addProduct(product: any) {
    this.itemCollection.doc(product.productID).set({
      dExpire: product.dExpire,
      dManufacture: product.dManufacture,
      manufactures: product.manufactures,
      name: product.name,
      image: product.image,
      price: product.price,
      type: product.type
    });
    this.itemCollection.add(product);
  }
  updateProduct(pProductID: string) {
    this.temp.productID = pProductID;
    this.temp.name = this.productProfile.get('nameProduct').value;
    this.temp.price = this.productProfile.get('priceProduct').value;
    if (this.productProfile.get('typeProduct').value === '') {
      this.temp.type = this.selectType;
    } else {
      this.temp.type = this.productProfile.get('typeProduct').value;
    }
    if (this.selectedFile === undefined) {
      this.temp.image = this.srcImg;
    } else {
      this.temp.image = this.selectedFile.name;
    }
    this.temp.dManufacture = this.productProfile.get('dManu').value;
    this.temp.dExpire = this.productProfile.get('dExpire').value;
    this.temp.manufactures = this.productProfile.get('manuProd').value;
    const data = JSON.parse(JSON.stringify(this.temp));
    console.log(data);
    this.itemCollection.doc(data.productID).set({
      dExpire: data.dExpire,
      dManufacture: data.dManufacture,
      manufactures: data.manufactures,
      image: data.image,
      name: data.name,
      price: data.price,
      type: data.type
    });
  }
  deleteProduct(productkey: string) {
    this.itemCollection.doc(productkey).delete().then(function () {
      console.log('Item' + productkey + 'has been deleted!');
    }).catch(function (error) {
      console.error('Error removing' + productkey + '!', error);
    });
  }
  OnSubmit(value): void {
    if (this.productProfile.valid) {
      const now = new Date();
      const myID = 'item-' + now.getDate().toString() + now.getMonth().toString() + now.getFullYear().toString()
        + now.getHours().toString() + now.getSeconds().toString() + now.getMilliseconds().toString();
      this.temp.productID = myID;
      this.temp.name = this.productProfile.get('nameProduct').value;
      this.temp.price = this.productProfile.get('priceProduct').value;
      this.temp.type = this.productProfile.get('typeProduct').value;
      this.temp.image = this.selectedFile.name;
      this.temp.dManufacture = this.productProfile.get('dManu').value;
      this.temp.dExpire = this.productProfile.get('dExpire').value;
      this.temp.manufactures = this.productProfile.get('manuProd').value;
      const data = JSON.parse(JSON.stringify(this.temp));
      this.addProduct(data);
    }
  }
  ngOnInit() {
  }
}
