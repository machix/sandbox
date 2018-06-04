import { Component, OnInit, Input, OnDestroy, ViewChild, EventEmitter, Output } from '@angular/core';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';

/**
 * This class represents the lazy loaded ModalWindowsComponent.
 */
@Component({
  selector: 'app-sd-modal-windows',
  templateUrl: 'modal-windows.component.html',
  styleUrls: ['modal-windows.component.scss']
})
export class ModalWindowsComponent implements OnDestroy {
  @ViewChild('loadSavedQueryModal') loadSavedQueryModal: any;
  @ViewChild('saveQueryModal') saveQueryModal: any;
  @ViewChild('saveQueryConfirmedModal') saveQueryConfirmedModal: any;
  @ViewChild('deleteStatementModal') deleteStatementModal: any;
  @ViewChild('deleteStatementConfirmedModal') deleteStatementConfirmedModal: any;
  @ViewChild('deleteTermModal') deleteTermModal: any;
  @ViewChild('deleteTermConfirmedModal') deleteTermConfirmedModal: any;

  loadSavedQueryModalRef: NgbModalRef;
  saveQueryModalRef: NgbModalRef;
  deleteStatementModalRef: NgbModalRef;
  deleteTermModalRef: NgbModalRef;

  @Output() confirmDeleteStatement: EventEmitter<string> = new EventEmitter();
  @Output() confirmDeleteTerm: EventEmitter<string> = new EventEmitter();

  /**
   * Creates an instance of the ModalWindowsComponent
   *
   */
  constructor(private modalService: NgbModal) {}

  openLoadSavedQueryModal() {
    this.loadSavedQueryModalRef = this.openModalWindow(this.loadSavedQueryModal);
  }

  openSaveQueryModal() {
    this.saveQueryModalRef = this.openModalWindow(this.saveQueryModal);
  }

  // confirm Save Query modal
  confirmSaveQuery() {
    this.saveQueryModalRef.close();

    this.openModalWindow(this.saveQueryConfirmedModal);
  }

  openDeleteStatementModal() {
    this.deleteStatementModalRef = this.openModalWindow(this.deleteStatementModal);
  }

  // confirm Delete Statement modal
  clickConfirmDeleteStatement() {
    this.confirmDeleteStatement.emit('');

    this.deleteStatementModalRef.close();

    this.openModalWindow(this.deleteStatementConfirmedModal);
  }

  openDeleteTermModal() {
    this.deleteTermModalRef = this.openModalWindow(this.deleteTermModal);
  }

  // confirm Delete Term modal
  clickConfirmDeleteTerm() {
    this.confirmDeleteTerm.emit('');

    this.deleteTermModalRef.close();

    this.openModalWindow(this.deleteTermConfirmedModal);
  }

  // openModalWindow
  openModalWindow(modalId) {
    const modalRef = this.modalService.open(modalId);
    modalRef.result.then((result) => {
    }, (reason) => {
    });
    return modalRef;
  }

  /**
   * OnDestroy
   */
  ngOnDestroy() {
    if (this.loadSavedQueryModalRef !== undefined) {
      this.loadSavedQueryModalRef.close();
    }
  }
}
