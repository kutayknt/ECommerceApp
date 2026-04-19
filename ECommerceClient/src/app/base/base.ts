import { NgxSpinnerService, Spinner } from "ngx-spinner";

export class Base {
  constructor(private spinner: NgxSpinnerService) {}
  showSpinner(spinnerNameType: SpinnerType) {
    this.spinner.show(spinnerNameType);

    setTimeout(() => this.hideSpinner(spinnerNameType),2000)
  }

  hideSpinner(spinnerNameType: SpinnerType) {
    this.spinner.hide(spinnerNameType);
  }
}
export enum SpinnerType{
  BallAtom = "s1",
  BallSpinClockwiseFadeRotating = "s2",
  BallScaleMultiple = "s3"
}
