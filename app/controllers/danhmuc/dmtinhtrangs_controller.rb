module Danhmuc
  class DmtinhtrangsController < PageController
    respond_to :html, :js

    def index
      @dmtinhtrangs = Dmtinhtrang.all
    end

    def show
      @dmtinhtrang = Dmtinhtrang.find(params[:id])
    end

    def edit
      @dmtinhtrang = Dmtinhtrang.find(params[:id])
    end

    def update
      @dmtinhtrangs = Dmtinhtrang.all
      @dmtinhtrang = Dmtinhtrang.find(params[:id])

      @dmtinhtrang.update_attributes(dmtinhtrang_params)
    end

    def new
      @dmtinhtrang = Dmtinhtrang.new
    end

    def create
      @dmtinhtrangs = Dmtinhtrang.all
      @dmtinhtrang = Dmtinhtrang.create(dmtinhtrang_params)
    end

    def delete
      @dmtinhtrang = Dmtinhtrang.find(params[:dmtinhtrang_id])
    end

    def destroy
      @dmtinhtrangs = Dmtinhtrang.all
      @dmtinhtrang = Dmtinhtrang.find(params[:id])
      @dmtinhtrang.destroy
    end

    private
    def dmtinhtrang_params
      params.require(:dmtinhtrang).permit(:stt, :ten)
    end
  end
end