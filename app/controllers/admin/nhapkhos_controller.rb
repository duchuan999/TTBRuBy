class Admin::NhapkhosController < ApplicationController

  def index
    @nhapkhos = Nhapll.all

    respond_to do |format|
      format.html
      format.js
      #format.json {render json: @nhapkhos}
    end
  end

  def new
    @nhapkhos = Nhapll.all

    @nhapkho = Nhapll.new
    respond_to do |format|
      format.html
      format.js
      #format.json {render json: @nhapkho}
    end
  end

  def create
    @nhapkho = Nhapll.new
    @nhapkho.create(nhapkho_params)

  end

  def edit
    @nhapkho= Nhapll.find(params[:id])
  end

  def update
    @nhapkhos= Nhapll.all
    @nhapkho=Nhapll.find(params[:id])
    @nhapkho.update_attributes(nhapkho_params)

  end
  def delete
    @nhapkho=Nhapll.find(params[:nhapkho_id])

  end
  def destroy
    @nhapkhos= Nhapll.all
    @nhapkho= Nhapll.find(params[:id])
    @nhapkho.destroy
  end
  private
  def nhapkho_params
    params.require(:nhapkho).permit(:sophieu,:ngaynhap,:sohoadon,:ngayhoadon,:bbkiem,:ngaykiem,:loai,:nguoigiao,:dmnhacc_id,:dmkho_id,:dmnguon_id,:no,:co,:chietkhau)
  end

end
