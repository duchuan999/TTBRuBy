class Admin::NhapllsController < ApplicationController

  def index
    @nhaplls = Nhapll.load
    @nhapcts = Nhapct.all
    respond_to do |format|
      format.html
      format.js
      #format.json {render json: @nhaplls}
    end
  end

  def new
    @nhaplls = Nhapll.all
    @nhapcts = Nhapct.all
    @nhapll = Nhapll.new
    @nhapct= Nhapct.new
    respond_to do |format|
      format.html
      format.js
      #format.json {render json: @nhapkho}
    end
  end

  def create
    @nhaplls=Nhapll.load
    @nhapcts = Nhapct.all

    @nhapll = Nhapll.new(nhapll_params)
    @nhapll= Nhapll.create(nhapll_params)

    #redirect_to (admin_nhaplls_path)
  end

  def edit
    @nhapll= Nhapll.find(params[:id])
  end

  def update
    @nhaplls= Nhapll.load
    @nhapcts = Nhapct.all
    @nhapll=Nhapll.find(params[:id])
    @nhapll.update_attributes(nhapll_params)

  end
  def delete
    @nhapll=Nhapll.find(params[:nhapll_id])

  end
  def destroy
    @nhaplls= Nhapll.load
    @nhapcts = Nhapct.all
    @nhapll= Nhapll.find(params[:id])
    @nhapll.destroy
  end
  private
  def nhapll_params
    params.require(:nhapll).permit(:sophieu,:ngaynhap,:sohoadon,:ngayhoadon,:bbkiem,:ngaykiem,:loai,:nguoigiao,:dmnhacc_id,:dmkho_id,:dmnguon_id,:no,:co,:chietkhau)
  end

end
