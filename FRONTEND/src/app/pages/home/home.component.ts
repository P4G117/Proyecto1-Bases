import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent{
  i=0;
  img=["../../../assets/images/image8.png",
          '../../../assets/images/image9.png',
          '../../../assets/images/image10.png',
          '../../../assets/images/image11.png']

  constructor() { }
  left() {
    if (this.i > 0) {
      this.i = this.i - 1;
    }
  }

  right() {
    if (this.i < 4) {
      this.i = this.i + 1;
    }
  }

}
