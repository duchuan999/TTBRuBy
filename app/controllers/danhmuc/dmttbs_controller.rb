module Danhmuc
  class DmttbsController < PageController

    helper_method :sort_column, :sort_direction
    respond_to :html, :js

    def index
      @dmttbs = Dmttb.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
      #@dmttbes=dmttb.all#.paginate(:page => params[:page], :per_page => 12)
    end

    def show
      @dmttb = Dmttb.find(params[:id])
    end

    def edit
      @dmttb = Dmttb.find(params[:id])
    end

    def update
      @dmttbs = Dmttb.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)

      @dmttb = Dmttb.find(params[:id])
      @dmttb.update_attributes(dmttb_params)
    end

    def new
      @dmttb = Dmttb.new
    end

    def create
      @dmttbs = Dmttb.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
      @dmttb = Dmttb.create(dmttb_params)
    end

    def delete
      @dmttb = Dmttb.find(params[:dmttb_id])
    end

    def destroy
      @dmttbs = Dmttb.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
      @dmttb = Dmttb.find(params[:id])
      @dmttb.destroy
    end

    private
    def sort_column
      Dmttb.column_names.include?(params[:sort]) ? params[:sort] : "ten"
    end

    def sort_direction
      %w[asc desc].include?(params[:direction]) ? params[:direction] : "asc"
    end

    # Never trust parameters from the scary internet, only allow the white list through.
    def dmttb_params
      params.require(:dmttb).permit(:stt, :ma, :ten, :model, :hamluong, :congsuat, :tylekh, :sodk, :sothe, :hinh, :dmdvt_id, :dmnhom_id, :dmhangsx_id, :dmnuocsx_id, :dmnhombc_id, :dmnhomin_id)
    end
  end
end