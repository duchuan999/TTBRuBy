class Admin::NhapctsController < ApplicationController
  
  def index
    @nhapcts = Nhapct.all

    respond_to do |format|
      format.html
      format.js
      #format.json {render json: @nhapcts}
    end
  end

  def new
    @nhapcts = Nhapct.all

    @nhapct = Nhapct.new
    respond_to do |format|
      format.html
      format.js
      #format.json {render json: @nhapkho}
    end
  end

  def create
    @nhapcts=Nhapct.all
    @nhapct = Nhapct.new(nhapct_params)
    @nhapct= Nhapct.create(nhapct_params)

    #redirect_to (admin_nhapcts_path)
  end

  def edit
    @nhapct= Nhapct.find(params[:id])
  end

  def update
    @nhapcts= Nhapct.all
    @nhapct=Nhapct.find(params[:id])
    @nhapct.update_attributes(nhapct_params)

  end
  def delete
    @nhapct=Nhapct.find(params[:nhapct_id])

  end
  def destroy
    @nhapcts= Nhapct.all
    @nhapct= Nhapct.find(params[:id])
    @nhapct.destroy
  end
  private
  def nhapct_params
    params.require(:nhapct).permit(:stt,:dmttb_id,:handung,:losx,:vat,:soluong,:dongia,:sotien,:giaban,:giamua,:tylekhauhao,:cuocvanchuyen,:chaythu,:tailieu,:nhapll_id,:namsx,:baohanh,:dmnguongoc_id,:dmtinhtrang_id,:sothe)
  end

end
